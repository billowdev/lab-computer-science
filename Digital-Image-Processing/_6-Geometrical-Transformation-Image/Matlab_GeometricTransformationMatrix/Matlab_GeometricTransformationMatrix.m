function [T] = GeometricTransformationMatrix(sx, sy, shx, shy, tx, ty, theta, cx, cy)
R = eye(3,3);
S = eye(3,3);
Sh = eye(3,3);
tr = eye(3,3);
tm = eye(3,3);
tp = eye(3,3);
tm(1,3) = -cx;
tm(2,3) = -cy;

R(1,1) = cos(theta * pi * 180);
R(2,2) = R(1,1);
R(1,2) = -sin(theta * pi / 180);
R(2,1) = sin(theta * pi / 180);
tp(1,3) = cx;
tp(2,3) = cy;

tr(1,3) = tx;
tr(2,3) = ty;
S(1,1) = sx; S(2,2) = sy;
Sh(1,2) = shx; Sh(2,1) = shy;
T = S * Sh * tp * R * tm * tr;
end