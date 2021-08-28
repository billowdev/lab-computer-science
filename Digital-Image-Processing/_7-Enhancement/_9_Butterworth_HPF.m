clear
% clf
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'}, 'File Selector');
pathf = strcat(pathname, filename);
bb = imread(pathf);
figure(1), image(bb), colormap(gray)
axis off

aa = im2double(bb);
FF = fft2(aa(:,:,1),512,512);
FF = fftshift(FF);
ct = [256,256];
mask = zeros(512,512);
n = 6;
d0 = 50;
for i=1:512
    for j=1:512
        mask(i,j) = 1/(1+[d0/sqrt((i-ct(1))^2+(j-ct(2))^2)]^(2*n));
    end
end
figure(2), surf(mask)
SS = FF.*mask;
kk = ifft2(SS,512,512);
output = abs(kk);
figure(3), imagesc(output), colormap(gray)
axis off
