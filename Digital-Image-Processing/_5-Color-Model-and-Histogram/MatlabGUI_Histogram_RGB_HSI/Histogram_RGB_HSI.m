function varargout = Histogram_RGB_HSI(varargin)
% HISTOGRAM_RGB_HSI MATLAB code for Histogram_RGB_HSI.fig
%      HISTOGRAM_RGB_HSI, by itself, creates a new HISTOGRAM_RGB_HSI or raises the existing
%      singleton*.
%
%      H = HISTOGRAM_RGB_HSI returns the handle to a new HISTOGRAM_RGB_HSI or the handle to
%      the existing singleton*.
%
%      HISTOGRAM_RGB_HSI('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in HISTOGRAM_RGB_HSI.M with the given input arguments.
%
%      HISTOGRAM_RGB_HSI('Property','Value',...) creates a new HISTOGRAM_RGB_HSI or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before Histogram_RGB_HSI_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to Histogram_RGB_HSI_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help Histogram_RGB_HSI

% Last Modified by GUIDE v2.5 24-Jul-2021 16:55:04

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @Histogram_RGB_HSI_OpeningFcn, ...
                   'gui_OutputFcn',  @Histogram_RGB_HSI_OutputFcn, ...
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


% --- Executes just before Histogram_RGB_HSI is made visible.
function Histogram_RGB_HSI_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to Histogram_RGB_HSI (see VARARGIN)

% Choose default command line output for Histogram_RGB_HSI
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes Histogram_RGB_HSI wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = Histogram_RGB_HSI_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pbtnRGB.
function pbtnRGB_Callback(hObject, eventdata, handles)
f = imread('forest_trees_fog.jpg');
handles.image = f;
guidata(hObject, handles);
subplot(311), imhist(f(:,:,1))
title('Histogram of Red Component')
axis ([0 255 0 10000])
subplot(312), imhist(f(:,:,2))
title('Histogram of Green Component')
axis ([0 255 0 10000])
subplot(313), imhist(f(:,:,3))
title('Histogram of Blue Component')
axis ([0 255 0 10000])
set(handles.pbtnHSI, 'Enable', 'on');

% --- Executes on button press in pbtnHSI.
function pbtnHSI_Callback(hObject, eventdata, handles)
h = rgb2hsv(handles.image);
subplot(311), imhist(h(:,:,1))
title('Histogram of Hue Component')
axis ([0 1 0 10000])
subplot(312), imhist(h(:,:,2))
title('Histogram of Saturation Component')
axis ([0 1 0 10000])
subplot(313), imhist(h(:,:,3))
title('Histogram of Value Component')
axis ([0 1 0 10000])
