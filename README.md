
# Windows Smart Ink 
A project that shows how to combine Microsoft's Custom Vision Service with Windows 10 Ink capabilities to create "smart ink".  Analyze ink strokes and classify the shapes to identify what the user is drawing.  Examples would be recoginizing product icons, technical diagrams components, etc.

[![Demo Video](/README_Images/Demo_Video.PNG?raw=true)](https://www.youtube.com/watch?v=5ht1CR8gm78) 

Trained models can be packaged and shared as Nuget packages and shared with others.

The project is currently comprised of two parts:
## Microsoft.MTC.SmarkInk Library
This library contains the components for creating, managing, utlizing and packaging smart ink models created using the Custom Vision Service.

## SmartInkLaboratory
Test harness for interacting with Custom Vision Service to train AI models to recognize ink patterns and to map ink patterns to icons/images.

## DemoApp
Simple demo applicaiton showing how to use two different models to understanding ink.

# Getting Started
There are two ways to use Windows Smart Ink.  The first is to use the Smart Ink Laboratory to create your own Smart Ink packages.  The other is to use Smart Ink packages that have been published to Nuget for inclusion in your own application.

## Creating Your Own Smart Ink Package
To create your won Smart Ink Package using the Smart Ink Laboratory, you need to use the [Microsoft Custom Vision Service](http://customvision.ai).  After creating a Custom Vision account, follow these steps to get the environment ready for use by the Smart Ink Laboratory application.

1. On the main Custom Vision page, click on **New Project**

![Custom Vision Home Page](https://github.com/Microsoft/MTC_WindowsSmartInk/blob/master/README_Images/ProjectsPage.PNG)

2. Fill out the form as shown:

![New Project](https://github.com/Microsoft/MTC_WindowsSmartInk/blob/master/README_Images/CreateNewProject.PNG)

Be sure to click the **Create New** if you want to create a new Azure Resource Group (non-trial).

3.  Once a new project is created, click on the Settings icon in the upper-right of the Custom Vision Service Home Page.

![Custom Vision Settings](https://github.com/Microsoft/MTC_WindowsSmartInk/blob/master/README_Images/ProjectPage-Settings.png)

4.  Copy the *Training Key* and *Prediction Key* for use in the Smart Ink Laboratory.

![Project Keys](https://github.com/Microsoft/MTC_WindowsSmartInk/blob/master/README_Images/SettingsKeys.PNG)

# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
