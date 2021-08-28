function varargout = Thresholding(varargin)
% THRESHOLDING MATLAB code for Thresholding.fig
%      THRESHOLDING, by itself, creates a new THRESHOLDING or raises the existing
%      singleton*.
%
%      H = THRESHOLDING returns the handle to a new THRESHOLDING or the handle to
%      the existing singleton*.
%
%      THRESHOLDING('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in THRESHOLDING.M with the given input arguments.
%
%      THRESHOLDING('Property','Value',...) creates a new THRESHOLDING or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before Thresholding_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to Thresholding_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help Thresholding

% Last Modified by GUIDE v2.5 24-Jul-2021 16:20:31

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @Thresholding_OpeningFcn, ...
                   'gui_OutputFcn',  @Thresholding_OutputFcn, ...
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


% --- Executes just before Thresholding is made visible.
function Thresholding_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to Thresholding (see VARARGIN)

% Choose default command line output for Thresholding
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes Thresholding wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = Thresholding_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
% [filename pathname] = uigetfile({'*.png';'*.jpg';'*bmp'},'File'
[filename pathname] = uigetfile({'*.*'},'File Selector');
pathf = strcat(pathname, filename);
f = imread(pathf);

fI = rgb2gray(f);
handles.image=fI(:,:,1);
guidata(hObject, handles)
imshow(fI)




% --- Executes on button press in togglebutton1.
function togglebutton1_Callback(hObject, eventdata, handles)
T = str2double(get(handles.edit2, 'string'))/255;
if (get(handles.togglebutton1, 'value')==0)
    g = im2bw(handles.image, T);
    imshow(g);
end


% --- Executes on button press in pushbutton2.
function pushbutton2_Callback(hObject, eventdata, handles)
try
    T = str2double(get(handles.edit2, 'string'))/255;
    if (get(handles.togglebutton1, 'value')==0)
        g = im2bw(handles.image, T);
        imshow(g);
    end
catch
   errbox = msgbox('Please try again Input Number in range 0-255');
end


function edit2_Callback(hObject, eventdata, handles)
% hObject    handle to edit2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of edit2 as text
%        str2double(get(hObject,'String')) returns contents of edit2 as a double


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

% --- Executes on slider movement.
function slider3_Callback(hObject, eventdata, handles)

if (get(handles.togglebutton1, 'value')==1)
    T=get(hObject,'value');
    handles.thresho = T;
    guidata(hObject, handles)
    g = im2bw(handles.image, T);
    imshow(g);
end

% --- Executes during object creation, after setting all properties.
function slider3_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end
