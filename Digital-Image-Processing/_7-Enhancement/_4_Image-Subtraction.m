clear
% clf
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
pathf = strcat(pathname, filename);
f = imread(pathf);
figure(1), imshow(f);

[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
pathf = strcat(pathname, filename);
g = imread(pathf);
figure(2), imshow(g);

s = imsubtract(g,f);
figure(2), imshow(s);
imwrite(s,'sub.jpg')