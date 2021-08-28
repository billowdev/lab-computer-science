clear
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
pathf = strcat(pathname, filename);
f=imread(pathf);
figure(1),imshow(f);
f = 255*im2double(f(:,:,1));

% Level Slice
a=130;
b=170;

for i=1:size(f,1)
    for j = 1:size(f,2)
        if f(i,j)>a && f(i,j)<b
            g(i,j,1)=0;
            g(i,j,2)=255;
            g(i,j,3)=0;
        else
            g(i,j,1)=f(i,j);
            g(i,j,2)=f(i,j);
            g(i,j,3)=f(i,j);
        end
    end
end
g = mat2gray(g);
figure(2), imshow(g);