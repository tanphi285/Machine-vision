import cv2
from PIL import Image
import numpy as np

# Khai bao duong dan file hinh 
source_file = r'D:\CODE\Python\LENA.jpg'

# Doc anh mau dung thu vien opencv
img = cv2.imread(source_file,cv2.IMREAD_COLOR)

# Doc anh mau dung thu vien pillow - dung de xu ly va tinh toan
imgPIL = Image.open(source_file)

#Tao anh dung de chua ket qua chuyen doi RGB sang Grayscale -> cung kich thuoc va mode voi anh imgPIL
AverageImage = Image.new(imgPIL.mode, imgPIL.size)

#lay kich thuoc anh ti imgPIL
width = AverageImage.size[0]
height = AverageImage.size[1]

#loop de doc het cac diem anh trong anh (ma tran 2 chieu -> 2 vong lap for)
for x in range(width):
    for y in range(height):
        #Lay gia tri diem anh tai vi tri (x,y)
        R, G, B = imgPIL.getpixel((x,y))

        #tinh toan chuyen doi diem anh RGB sang GrayScale dung pp Average
        gray = np.uint8((R+G+B)/3)

        #gan gia tri muc xam vua tinh cho anh
        AverageImage.putpixel((x,y),(gray,gray,gray))

#Chuyen anh tu PIL sang OpenCV de hien thi
grayscale_img = np.array(AverageImage)    

#Hien thi anh
cv2.imshow('Source Image: ', img)
cv2.imshow('Average Grayscale image: ', grayscale_img)
cv2.waitKey(0)
cv2.destroyAllWindows()
     
#                                       developed by Cao Tan Phi - 20146513