OpenGL Teapot Renderer Wrapper for VB.NET WinForms
This project provides a wrapper for an OpenGL-based 3D teapot rendering and animation system, designed to be integrated into VB.NET WinForms applications. It demonstrates the power of combining native OpenGL rendering with .NET's user-friendly GUI framework.
Project Overview
The core of this project is a C++ wrapper class that encapsulates OpenGL and GLUT functionality to render and animate a 3D teapot. This native code is then exposed to a VB.NET WinForms application through a DLL, allowing seamless integration of high-performance 3D graphics into a .NET environment.
Key features include:

Real-time 3D rendering of a wireframe teapot
Smooth rotation animation
User interaction through mouse controls:

Left-click and drag to rotate the teapot manually
Right-click to access a context menu
Scroll to zoom in/out


A toolbar displaying project information
An informative message box with usage instructions

Technical Details
The project is split into two main components:

C++ DLL:

Wraps the OpenGL and GLUT code into a class structure
Handles the core rendering and animation logic
Exposes key functions for initialization and main loop execution


VB.NET WinForms Application:

Provides a user-friendly GUI
Interfaces with the C++ DLL using P/Invoke
Manages the lifecycle of the OpenGL rendering context



How It Works

The VB.NET application initializes the wrapper through the DLL.
The OpenGL context is created and managed by the C++ code.
The teapot is rendered and animated in real-time.
User interactions are captured by the WinForms app and passed to the OpenGL context.

Usage
To use this in your own VB.NET WinForms project:

Include the compiled DLL in your project.
Use the provided P/Invoke declarations to interface with the DLL.
Initialize the wrapper and start the rendering loop from your WinForms code.

Building the Project
Detailed build instructions are provided in the project documentation.
Dependencies
This project relies on the following libraries and languages:

OpenGL: For 3D graphics rendering
GLUT (OpenGL Utility Toolkit): For window management and user input handling
C++: For the core rendering engine and wrapper class
VB.NET: For the WinForms application
