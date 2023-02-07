import cv2;
import numpy as np;

#doc anh mau dung thu vien opencv
img = cv2.imread('D:\CODE\Python\LENA.jpg',cv2.IMREAD_COLOR)

#lay kich thuoc cua anh
height = len(img[0])
width = len(img[1])

#bien chua hinh 3 kenh RGB 
red = np.zeros((width,height,3), np.uint8)
green = np.zeros((width,height,3), np.uint8)
blue = np.zeros((width,height,3), np.uint8)

#set zero cho 3 kenh mau
red[:] = [0,0,0]    #[height,width,color]
green[:] = [0,0,0]
blue[:] = [0,0,0]

#loop de doc het cac diem anh
for i in range(0,height):
    for j in range(0,width):
        R = img[i,j,2]
        G = img[i,j,1]
        B = img[i,j,0]

        #thiet lap mau cho cac kenh
        red[i,j,2] = R
        green[i,j,1] = G
        blue[i,j,0] = B

#hien thi hinh dung thu vien opencv
cv2.imshow('Anh goc RGB:' , img)
cv2.imshow('Kenh mau RED:' , red)
cv2.imshow('Kenh mau GREEN:', green)
cv2.imshow('Kenh mau BLUE:', blue)
cv2.waitKey(0)
cv2.destroyAllWindows()
#...................Developed by Cao Tan Phi - 20146513...............................