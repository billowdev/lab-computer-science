# faceDetect.py
# ref: AI บ้านบ้าน (รศดร ปริญญา สงวนสัต)
# https://www.youtube.com/watch?v=gT3uELrVpOs

import cv2, dlib, pickle 
import numpy as np 

face_detector = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
detector = dlib.get_frontal_face_detector() 
sp = dlib.shape_predictor('shape_predictor_68_face_landmarks.dat')
model = dlib.face_recognition_model_v1('dlib_face_recognition_resnet_model_v1.dat')
FACE_DESC, FACE_NAME = pickle.load(open('trainset.pk', 'rb'))

cap = cv2.VideoCapture(0)

while True: 
	_, frame = cap.read() 
	gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY) 
	faces = face_detector.detectMultiScale(gray, 1.1, 4)

	for (x, y, w, h) in faces:
		img = frame[y-10:y+h+10, x-10:x+w+10][:,:,::-1]
		dets = detector(img, 1)

		for k, d in enumerate(dets):
			shape = sp(img, d)
			face_desc0 = model.compute_face_descriptor(img, shape, 1)
			d = []

			for face_desc in FACE_DESC:
				d.append(np.linalg.norm(np.array(face_desc) - np.array(face_desc0)))
			d = np.array(d)
			idx = np.argmin(d)

			if d[idx] > 0.5:
				name = "Unknown"
				cv2.putText(frame, name, (x, y - 5), cv2.FONT_HERSHEY_COMPLEX, .7, (255, 255, 255), 2)
				cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 0, 255), 2)

			else:
				name = FACE_NAME[idx]
				print(name)
				cv2.putText(frame, name, (x, y - 5), cv2.FONT_HERSHEY_COMPLEX, .7, (255, 255, 255), 2)
				cv2.rectangle(frame, (x, y), (x + w, y + h), (0, 0, 255), 2)

	cv2.imshow('frame', frame)
	if cv2.waitKey(1) & 0xFF == ord('q'):
		break
