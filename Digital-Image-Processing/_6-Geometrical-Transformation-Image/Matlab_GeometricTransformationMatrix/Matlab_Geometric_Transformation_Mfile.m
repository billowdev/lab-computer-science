clear
clf
[filename pathname] = uigetfile({'*.png'; '*.jpg'; '*.bmp'}, 'File Selector');
pathf = strcat(pathname, filename);
f = imread(pathf);

figure(1), imshow(f)
f = 255 * im2double(f);
T = GeometricTransformationMatrix(1,1,0,0,0,0,30,30,30);
Tinv = inv(T);

for u=1:size(f,1)
    for v=1:size(f,2)
        P = [u;v;1];
        Q = Tinv * P;
        x = round(Q(1)/Q(3));
        y = round(Q(2)/Q(3));
        if (x>0) & (y>0) & (x<size(f,1)) & (y<size(f,2))
            g(u,v,1) = f(x,y,1);
            g(u,v,2) = f(x,y,2);
            g(u,v,3) = f(x,y,3);
        end
    end
end
g = mat2gray(g);
figure(2), imshow(g)
