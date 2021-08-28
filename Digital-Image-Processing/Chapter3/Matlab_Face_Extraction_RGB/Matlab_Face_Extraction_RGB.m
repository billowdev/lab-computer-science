%Pre process
% ตรวจหาสีผิวในโหมด RGB
clear
clc
f = imread('testimg.png')
figure(1), imshow(f)

%Process
%g = rgb2ycbcr(f)
%cb = g(:,:,2);
%cr = g(:,:,3);
face = zeros(size(f,1), size(f,3));

for i=1:size(f,1)
    for j=1:size(f,2)
        R = f(i, j, 1);
        G = f(i, j, 2);
        B = f(i, j, 3);
        
        if(R> 95 & G>40 & B>20) % ref: https://arxiv.org/ftp/arxiv/papers/1708/1708.02694.pdf
            v = [R,G,B];   
            if((max(v) - min(v)) > 15)
                if(abs(R-G) > 15 & R > G & R > B) % ref: https://www.mathworks.com/matlabcentral/answers/146906-matlab-code-for-face-detection-using-rgb-space-color-skin-color
                    % skin
                    face(i,j) = 1;
                end
            end
        end
    end
end

%Post Process
%face = mat2gray(face);


figure(2), imshow(face)
