clear
% clf
[filename pathname] = uigetfile({'*.jpg';'*.png';'*.bmp'}, 'File Selector');
pathf = strcat(pathname, filename);
f = imread(pathf);
figure(1), imshow(f);
% ---------- Process ---------- %
f = 255*im2double(f);
R = f(:,:,1);
G = f(:,:,2);
B = f(:,:,3);
h = (1/9)*ones(3,3);

for i=1:size(f,1)-2
    for j=1:size(f,2)-2
        w = R(i:i+2, j:j+2);
        nR(i,j) = sum(sum(w.*h));
        w = G(i:i+2,j:j+2);
        nG(i,j)=sum(sum(w.*h));
        w = B(i:i+2,j:j+2);
        nB(i,j) = sum(sum(w.*h));
    end
end

R1 = mat2gray(nR);
G1 = mat2gray(nG);
B1 = mat2gray(nB);
g1 = cat(3,R1,G1,B1);
figure(2), imshow(g1)

nR = conv2(R,h,'same');
nG = conv2(G,h,'same');
nB = conv2(B,h,'same');
R1 = mat2gray(nR);
G1 = mat2gray(nG);
B1 = mat2gray(nB);
g1 = cat(3,R1,G1,B1);
figure(2), imshow(g1)

