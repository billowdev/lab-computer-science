clear
% clf
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
pathf = strcat(pathname, filename);
f=imread(pathf);

f = 255*im2double(f(:,:,1));
figure(1),imshow(f);

for i=1:size(f,1)
    for j=1:size(f,2)
        bin = dec2bin(f(i,j),8);
        b0(i,j) = double(bin(1));
        b1(i,j) = double(bin(2));
        b2(i,j) = double(bin(3));
        b3(i,j) = double(bin(4));
        b4(i,j) = double(bin(5));
        b5(i,j) = double(bin(5));
        b6(i,j) = double(bin(7));
        b7(i,j) = double(bin(8));
    end
end

subplot(2,4,1), imagesc(b7)
subplot(2,4,2), imagesc(b6)
subplot(2,4,3), imagesc(b5)
subplot(2,4,4), imagesc(b4)
subplot(2,4,5), imagesc(b3)
subplot(2,4,6), imagesc(b2)
subplot(2,4,7), imagesc(b1)
subplot(2,4,8), imagesc(b0)

% ------------ Reverse  ------------ %

for i=1:size(f,1)
    for j=1:size(f,2)
        b(1) = char(48);
        b(2) = char(b1(i,j));
        b(3) = char(b2(i,j));
        b(4) = char(b3(i,j));
        b(5) = char(b4(i,j));
        b(6) = char(b5(i,j));
        b(7) = char(b6(i,j));
        b(8) = char(b7(i,j));
        g(i,j) = bin2dec(b);
    end
end
g = mat2gray(g);
figure(2), imshow(g)