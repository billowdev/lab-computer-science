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
        Q(1) = Q(1)/Q(3); Q(2) = Q(2) / Q(3);
        
        x0 = floor(Q(1)); x1 = ceil(Q(1));
        y0 = floor(Q(2)); y1 = ceil(Q(2));
        
        if x0>0 && x0<=size(f,1) && x1>0 && x1<=size(f,2) && y0>0 && y0<=size(f,1) && y1>0 && y1<=size(f,2)
            A = (f(x0, y0) - f(x0, y0)) * rem(x0,1)+f(x0, y0);
            B = (f(x0, y1) - f(x0, y1)) * rem(x0,1)+f(x0,y1);
            G(u,v) = (B-A) * rem(y0, 1)+A;
        end
    end
end
G = mat2gray(G);
figure(2), imshow(G)
