# faceExtract.py
# ref: AI บ้านบ้าน (รศดร ปริญญา สงวนสัต)
# https://www.youtube.com/watch?v=gT3uELrVpOs

import numpy as np
import cv2, dlib, os, pickle
import time
path = './faceData/'
detector = dlib.get_frontal_face_detector()
sp = dlib.shape_predictor('shape_predictor_68_face_landmarks.dat')
model = dlib.face_recognition_model_v1('dlib_face_recognition_resnet_model_v1.dat')

FACE_DESC = []
FACE_NAME = []

for fn in os.listdir(path):
    if fn.endswith('.jpg'):                    # เช็คว่า ลงท้ายด้วย .jpg หรือปล่าว

        img = cv2.imread(path + fn)[:,:,::-1]    # แล้วก็ใช้ open cv อ่านรูปขึ้นมา  # [:,:,::-1] คือการ สลับปริภูมิ จาก BGR เป็น RGB
        dets = detector(img, 1)               # เอา detector มาใช้

        for k, d in enumerate(dets):          # วน for หาว่า มันมีรูปอะไรบ้างใน dets ที่ ดีเทคมา
            shape = sp(img, d)
            face_desc = model.compute_face_descriptor(img, shape, 1)
            FACE_DESC.append(face_desc) # เอาไปเก็บไว้ใน face_desc
            print("loading...", fn) # บอกว่ามันได้ทำการโหลดภาพชื่ออะไรไปบ้าง
            FACE_NAME.append(fn[:fn.index('_')]) # เอาชื่อจากชื่อไฟล์

# เก็บ
pickle.dump((FACE_DESC, FACE_NAME), open('trainset.pk', 'wb'))


