function varargout = AverageBlurListbox(varargin)
% AVERAGEBLURLISTBOX MATLAB code for AverageBlurListbox.fig
%      AVERAGEBLURLISTBOX, by itself, creates a new AVERAGEBLURLISTBOX or raises the existing
%      singleton*.
%
%      H = AVERAGEBLURLISTBOX returns the handle to a new AVERAGEBLURLISTBOX or the handle to
%      the existing singleton*.
%
%      AVERAGEBLURLISTBOX('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in AVERAGEBLURLISTBOX.M with the given input arguments.
%
%      AVERAGEBLURLISTBOX('Property','Value',...) creates a new AVERAGEBLURLISTBOX or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before AverageBlurListbox_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to AverageBlurListbox_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help AverageBlurListbox

% Last Modified by GUIDE v2.5 24-Jul-2021 16:24:24

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @AverageBlurListbox_OpeningFcn, ...
                   'gui_OutputFcn',  @AverageBlurListbox_OutputFcn, ...
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


% --- Executes just before AverageBlurListbox is made visible.
function AverageBlurListbox_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to AverageBlurListbox (see VARARGIN)

% Choose default command line output for AverageBlurListbox
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes AverageBlurListbox wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = AverageBlurListbox_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
[filename pathname] = uigetfile({'*.*'}, 'File Selector');
pathf = strcat(pathname, filename);

f = imread(pathf);
handles.image = f;
guidata(hObject, handles);
imshow(f);

% --- Executes on selection change in popupmenu1.
function popupmenu1_Callback(hObject, eventdata, handles)
item = get(hObject, 'value');
switch item
    case 1 
        H = fspecial('gaussian');
        sharpened = imfilter(handles.image, H);
        imshow(sharpened);
        set(handles.listbox1, 'String', 'Averaging is performed');
    case 2
        H = fspecial('average');
        sharpened = imfilter(handles.image, H);
        imshow(sharpened);
        set(handles.listbox1, 'String', 'Blurring is performed');
end
% --- Executes during object creation, after setting all properties.
function popupmenu1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to popupmenu1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: popupmenu controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on selection change in listbox1.
function listbox1_Callback(hObject, eventdata, handles)
% hObject    handle to listbox1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: contents = cellstr(get(hObject,'String')) returns listbox1 contents as cell array
%        contents{get(hObject,'Value')} returns selected item from listbox1


% --- Executes during object creation, after setting all properties.
function listbox1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to listbox1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: listbox controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end
