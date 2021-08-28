function [s,p] = sumprod(f,g)
fd = im2double(f);
gd=im2double(g);
pd=fd*gd;
sd=fd+gd;
s=mat2gray(sd);
p=mat2gray(pd);
