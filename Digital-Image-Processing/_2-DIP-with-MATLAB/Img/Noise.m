%preprocessing
clear
clc

f=imread('baloon.jpg');
figure(1), imshow(f);

%processing
f1=im2double(f);
R=f1(:,:,1);
G=f1(:,:,2);
B=f1(:,:,3);
sc=0.8;
nR=R+sc*rand(size(f,1),size(f,2));
nG=G+sc*rand(size(f,1),size(f,2));
nB=B+sc*rand(size(f,1),size(f,2));

%post processing
R1=mat2gray(nR);
G1=mat2gray(nG);
B1=mat2gray(nB);
g1=cat(3,R1,G1,B1);

figure(2),imshow(g1);


