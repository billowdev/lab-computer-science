clear
clc
buffer = imread('braninmri.jpg');
R=buffer(:,:,1);
G=buffer(:,:,2);
B=buffer(:,:,3);
I=0.3*(R+G+B);
imshow(I); colormap('gray');

