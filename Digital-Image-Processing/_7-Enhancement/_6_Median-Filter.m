clear
% clf
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
pathf = strcat(pathname, filename);
f = imread(pathf);

f = imnoise(f,'salt & pepper');
figure(1), imshow(f);
f = 255*im2double(f);

for i=1:size(f,1)-2
    for j=1:size(f,2)-2
        g(i,j,1) = median(median(f(i:i+2,j:j+2,1)));
        g(i,j,2) = median(median(f(i:i+2,j:j+2,2)));
        g(i,j,3) = median(median(f(i:i+2,j:j+2,3)));
    end
end
g = mat2gray(g)
figure(2), imshow(g)
