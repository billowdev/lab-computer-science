clear
% clf
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selection');
pathf = strcat(pathname, filename);
f = imread(pathf);

figure(1), image(f);
f = im2double(f);
F = fft2(f(:,:,1), 64, 64)
F = fftshift(F);
figure(2), surf(abs(F))
axis([0 63 0 63 0 800])
ct = [33 33];
H = zeros(64, 64);
for i=1:64
    for j=1:64
        if sqrt((i-ct(1))^2+(j-ct(2))^2)<10
            H(i,j)=1;
        end
    end
end
figure(3), surf(H)
axis([0 63 0 63 0 1])
G = F.*H;
G = ifft2(G,64,64);
G = abs(G);
G = mat2gray(G);
figure(4), imagesc(G);colormap('gray')
