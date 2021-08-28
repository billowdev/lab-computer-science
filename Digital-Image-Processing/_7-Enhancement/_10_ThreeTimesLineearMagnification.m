clear
% clc
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
pathf = strcat(pathname, filename);
f = imread(pathf);
f = 255 * im2double(f);
r = f(:,:,1); g = f(:,:,2); b = f(:,:,3);
z = 3;
zr = zeros(z*size(f,1), z*size(f,2));
zg = zeros(z*size(f,1), z*size(f,2));
zb = zeros(z*size(f,1), z*size(f,2));

for i=1:size(f,1)
    for j=1:size(f,2)
        zr(z*i,z*j)=r(i,j);
        zg(z*i,z*j)=g(i,j);
        zb(z*i,z*j)=b(i,j);
    end
end

% ---------- Convolution ---------- %
figure(1), imagesc(zr), colormap(gray)
h = (1/2)*ones(3,3);h(2,2)=1;
h(1,1)=1/4; h(1,3)=1/4;
h(3,1)=1/4; h(3,3)=1/4;

er = conv2(zr,h,'same');
eg = conv2(zg,h,'same');
eb = conv2(zb,h,'same');

fr = conv2(er,h,'same');
fg = conv2(eg,h,'same');
fb = conv2(eb,h,'same');

gr = conv2(fr,h,'same');
gg = conv2(fg,h,'same');
gb = conv2(fb,h,'same');

e = cat(3,gr,gg,gb);
e = mat2gray(e);
figure(2), imshow(e)
