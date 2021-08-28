
#### MatlabGUI_Histogram

-----------------------
- pre-process
<pre>
clc
cam = webcam    % use webcam 
handles.vid = cam;
guidata(hObject, handles);
preview(handles.vid) % show webcam
</pre>
- process
<pre>
im=snapshot(handles.vid);  % capture
figure(2), imshow(im);  % show 
imwrite(im, 'Screenshot.jpg');  % save
</pre>
- psot-process
<pre>
closePreview(handles.vid); % stop webcam
clear
</pre>
