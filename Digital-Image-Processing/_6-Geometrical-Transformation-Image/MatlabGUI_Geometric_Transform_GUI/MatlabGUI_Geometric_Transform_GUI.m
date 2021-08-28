function varargout = MatlabGUI_Geometric_Transform_GUI(varargin)
% MATLABGUI_GEOMETRIC_TRANSFORM_GUI MATLAB code for MatlabGUI_Geometric_Transform_GUI.fig
%      MATLABGUI_GEOMETRIC_TRANSFORM_GUI, by itself, creates a new MATLABGUI_GEOMETRIC_TRANSFORM_GUI or raises the existing
%      singleton*.
%
%      H = MATLABGUI_GEOMETRIC_TRANSFORM_GUI returns the handle to a new MATLABGUI_GEOMETRIC_TRANSFORM_GUI or the handle to
%      the existing singleton*.
%
%      MATLABGUI_GEOMETRIC_TRANSFORM_GUI('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in MATLABGUI_GEOMETRIC_TRANSFORM_GUI.M with the given input arguments.
%
%      MATLABGUI_GEOMETRIC_TRANSFORM_GUI('Property','Value',...) creates a new MATLABGUI_GEOMETRIC_TRANSFORM_GUI or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before MatlabGUI_Geometric_Transform_GUI_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to MatlabGUI_Geometric_Transform_GUI_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help MatlabGUI_Geometric_Transform_GUI

% Last Modified by GUIDE v2.5 01-Aug-2021 10:36:40

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @MatlabGUI_Geometric_Transform_GUI_OpeningFcn, ...
                   'gui_OutputFcn',  @MatlabGUI_Geometric_Transform_GUI_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before MatlabGUI_Geometric_Transform_GUI is made visible.
function MatlabGUI_Geometric_Transform_GUI_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to MatlabGUI_Geometric_Transform_GUI (see VARARGIN)

% Choose default command line output for MatlabGUI_Geometric_Transform_GUI
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes MatlabGUI_Geometric_Transform_GUI wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = MatlabGUI_Geometric_Transform_GUI_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure

varargout{1} = handles.output;

% --- Executes on slider movement.
function slider1_Callback(hObject, eventdata, handles)




% --- Executes during object creation, after setting all properties.
function slider1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


function edit1_Callback(hObject, eventdata, handles)

% --- Executes during object creation, after setting all properties.
function edit1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


function edit2_Callback(hObject, eventdata, handles)


% --- Executes during object creation, after setting all properties.
function edit2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end

function edit3_Callback(hObject, eventdata, handles)


% --- Executes during object creation, after setting all properties.
function edit3_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


function edit4_Callback(hObject, eventdata, handles)


% --- Executes during object creation, after setting all properties.
function edit4_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end

function pushbutton1_Callback(hObject, eventdata, handles)

% ---------Edit1 Sx ------------- %
sx = str2double(get(handles.edit1, 'string'));

% ----------Edit2 sy ------------ %
sy = str2double(get(handles.edit2,'string'));

% ----------Edit3 shx ------------ %
shx = str2double(get(handles.edit3, 'string'));

% ----------Edit4 shy ------------ %
shy = str2double(get(handles.edit4, 'string'));

% ------------Slider theta--------------- %
theta = get(handles.slider1, 'value');
theta = theta * pi * 180;
%-------------------------------------%

f = imread('testImg.jpg');

% Tscale = [sx 0 0; 0 sy 0; 0 0 1];
Tscale = vertcat([sx 0 0], [0 sy 0], [0 0 1])
%-------------------------------------------------------------%
% Trotation = [cos(th) sin(th) 0; -sin(th) cos(th) 0; 0 0 1];
Trotation = vertcat([cos(theta) sin(theta) 0], [-sin(theta) cos(theta) 0], [ 0 0 1]);
%-------------------------------------------------------------%
% Tshear = [1 shx 0; shy 1 0; 0 0 1];
Tshear = vertcat([1 shx 0], [shy 1 0], [0 0 1]);

T = Tscale * Trotation * Tshear;

% tform = maketform('testImg.jpg', T); %Err Unrecognized TRANSFORMTYPE: 'testImg.jpg'.
tform = maketform('affine', T);
% can change to => tform = affine2d(T); % https://www.mathworks.com/help/images/ref/affine2d.html

% ---------------------------------------------------
% imtransform is not recommended. Use imwarp instead.
g = imtransform(f, tform, 'bilinear');
% can chage to => g = imwarp(f, tform); % https://www.mathworks.com/help/images/ref/imwarp.html
%g = RotateFunc(Rf, Gf, Bf, sx, sy, th, shx, shy);
imshow(g);
