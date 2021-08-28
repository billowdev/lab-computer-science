clear
% clf
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
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
        mask(i,j) = 1/(1+[sqrt((i-ct(1))^2+(j-ct(2))^2)/d0]^(2*n));
    end
end
figure(2), surf(mask)
LL = FF.*mask;
pp = ifft2(LL,512,512);
output = abs(pp);
figure(3), imagesc(output), colormap(gray)
axis off
