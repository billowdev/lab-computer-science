%preprocessing
clear
clc
f=imread('boats.jpg');
figure (1), imshow(f);
%processing
f1=255*im2double(f);
bin=zeros(1,256);
for i=1:size(f1,1)
    for j=1:size(f1,1)
        bin(f1(i,j,1)+1)=bin(f1(i,j,1)+1)+1;
    end
end
%post process
figure(2), plot([1:256],bin,'b');
    
   
