clear
clf
Tscale = [0.5 0 0; 0 0.8 0; 0 0 1];
Trotation = [cos(pi/4) sin(pi/4) 0; -sin(pi/4) cos(pi/4) 0; 0 0 1];
Tshear = [1 0 0; 0.2 1 0; 0 0 1];
T = Tscale * Trotation * Tshear;
tform = maketform('affine', T);

f = imread('testImg.jpg');
f = im2double(f(:, :, 1));

g1 = imtransform(f, tform, 'bilinear');

% use imrotate
g2 = imrotate(f, 45, 'bicubic', 'loose');

% use imresize
g3 = imresize(f, 3, 'nearest');

f1 = figure("Name", "Original"), imagesc([5 8], [3, 6], f), colormap('gray');
f1.Position = [1.8000  361.8000  560.0000  420.0000];

f2 = figure("Name", "imtranform"), imagesc(g1), colormap('gray');
f2.Position = [484.2000  361.8000  560.0000  420.0000]

f3 = figure("Name", "imrotate"), imagesc(g2), colormap('gray');
f3.Position = [939.4000  352.2000  560.0000  420.0000]

f4 = figure("Name", "imresize"), imagesc(g3), colormap('gray');
f4.Position = [445.8000   22.6000  560.0000  420.0000]
