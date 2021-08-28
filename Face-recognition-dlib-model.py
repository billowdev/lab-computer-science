# ref: AI บ้าน บ้าน 
# https://www.youtube.com/watch?v=gT3uELrVpOs

import numpy as np 
import cv2   
import dlib # install cmake ก่อน
# dlib C++ library ซึ่งมี Machine learning algorithms และ เครื่องมือต่างๆในการสร้างโปรแกรมที่ซับซ้อน อย่างระบบการจดจำใบหน้าก็มี moduleไว้
import os
import pickle

def faceExtraction():
	path = './faceData/'
	#----------------------------------------------------------------------------#
	detector = dlib.get_frontal_face_detector()
	sp = dlib.shape_predictor('shape_predictor_68_face_landmarks.dat')
	model = dlib.face_recognition_model_v1('dlib_face_recognition_resnet_model_v1.dat')
	#----------------------------------------------------------------------------#
	FACE_DESC = []
	FACE_NAME = []

	for fn in os.listdir(path):
		if fn.endswith('.jpg'):                    # เช็คไฟล์ที่ลงท้ายด้วย .jpg 

			img = cv2.imread(path + fn)[:,:,::-1]    # ใช้ open cv อ่านรูปขึ้นมา  # [:,:,::-1] คือการ สลับปริภูมิ จาก BGR เป็น RGB
			dets = detector(img, 1)                   # เอา detector มาใช้

			for k, d in enumerate(dets):   # วน for หาว่า มันมีรูปอะไรบ้างใน dets ที่ ดีเทคมา
				shape = sp(img, d)
				face_desc = model.compute_face_descriptor(img, shape, 1)
				FACE_DESC.append(face_desc) # เอาไปเก็บไว้ใน face_desc
				print("loading...", fn)      # บอกว่ามันได้ทำการโหลดภาพชื่ออะไรไปบ้าง
				FACE_NAME.append(fn[:fn.index('_')])   # เอาชื่อจากชื่อไฟล์ ตัดข้อความหลัง _ ออก

	pickle.dump((FACE_DESC, FACE_NAME), open('trainset.pk', 'wb'))  # ดัมพ์ไฟล์เก็บไว้ชื่อ trainset.pk


def faceDetection():
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


# ฟังก์ชัน faceExtraction จะต้องรันก็ต่อเมื่อต้องการ เทรนภาพใหม่ หรือมีภาพเพิ่มมา
# faceExtraction()

cap = cv2.VideoCapture(0) # ใช้กล้อง

#----------------------------------------------------------------------------#
face_detector = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
detector = dlib.get_frontal_face_detector() 
sp = dlib.shape_predictor('shape_predictor_68_face_landmarks.dat')
model = dlib.face_recognition_model_v1('dlib_face_recognition_resnet_model_v1.dat')

#----------------------------------------------------------------------------#
FACE_DESC, FACE_NAME = pickle.load(open('trainset.pk', 'rb'))  # อ่านไฟล์รูปภาพที่เทรนไว้แล้ว
#----------------------------------------------------------------------------#

while True: 
	_, frame = cap.read() 
	gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY) 
	faces = face_detector.detectMultiScale(gray, 1.1, 4)

	faceDetection()  # ฟังก์ชันสำหรับการ ตรวจจับใบหน้า จากไฟล์ที่ได้ทำการ เทรนโมเดลไว้แล้ว

	if cv2.waitKey(1) & 0xFF == ord('q'):
		break

