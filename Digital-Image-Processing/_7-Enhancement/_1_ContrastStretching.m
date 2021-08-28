clear
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'},'File Selector');
pathf = strcat(pathname, filename);
f = imread(pathf);

figure(1), imshow(f);
figure(2), imhist(f(:,:,1));

f = 255 * im2double(f(:,:,1));
a = min(min(f));
b = max(max(f));
va = 20;
vb = 240;

alpha = va/a;
beta = (vb-va)/(b-a);
gamma = (255-vb)/(255-b);

for i=1:size(f,1)
    for j=1:size(f,2)
        if f(i,j)>0 && f(i,j)<a
            g(i,j) = alpha * f(i,j);
        elseif f(i,j)>a && f(i,j)<b
            g(i,j) = beta * (f(i,j)-a)+va;
        else
            g(i,j) = gamma * (f(i,j)-b)+vb;
        end
    end
end
g = mat2gray(g);
figure(3), imshow(g)
figure(4), imhist(g)

            

