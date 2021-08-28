function varargout = snapshotWebcam(varargin)
% SNAPSHOTWEBCAM MATLAB code for snapshotWebcam.fig
%      SNAPSHOTWEBCAM, by itself, creates a new SNAPSHOTWEBCAM or raises the existing
%      singleton*.
%
%      H = SNAPSHOTWEBCAM returns the handle to a new SNAPSHOTWEBCAM or the handle to
%      the existing singleton*.
%
%      SNAPSHOTWEBCAM('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in SNAPSHOTWEBCAM.M with the given input arguments.
%
%      SNAPSHOTWEBCAM('Property','Value',...) creates a new SNAPSHOTWEBCAM or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before snapshotWebcam_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to snapshotWebcam_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help snapshotWebcam

% Last Modified by GUIDE v2.5 24-Jul-2021 16:28:03

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @snapshotWebcam_OpeningFcn, ...
                   'gui_OutputFcn',  @snapshotWebcam_OutputFcn, ...
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


% --- Executes just before snapshotWebcam is made visible.
function snapshotWebcam_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to snapshotWebcam (see VARARGIN)

% Choose default command line output for snapshotWebcam
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes snapshotWebcam wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = snapshotWebcam_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;

% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
clc
cam = webcam    % use webcam 
handles.vid = cam;
guidata(hObject, handles);
preview(handles.vid) % show webcam


% --- Executes on button press in pushbutton2.
function pushbutton2_Callback(hObject, eventdata, handles)

im=snapshot(handles.vid);  % capture
figure(2), imshow(im);  % show 
imwrite(im, 'Screenshot.jpg');  % save

% --- Executes on button press in pushbutton3.
function pushbutton3_Callback(hObject, eventdata, handles)
closePreview(handles.vid); % stop webcam
clear
