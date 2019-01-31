#!/bin/bash

IFIT_PROJECT_NAME=LaunchDarklyIosBinding

IFIT_MYGET_SOURCE=https://www.myget.org/F/orbital-drop-bear
IFIT_MYGET_KEY=a3606564-016d-4678-9d1f-62c301fbebfa

git clean -fdX
msbuild $IFIT_PROJECT_NAME.sln /p:Configuration=Release
msbuild $IFIT_PROJECT_NAME/$IFIT_PROJECT_NAME.csproj /p:Configuration=Release /t:pack

if [ "$1" = "--deploy" ]
then
  nuget push $IFIT_PROJECT_NAME/bin/Release/$IFIT_PROJECT_NAME.*.nupkg $IFIT_MYGET_KEY -Source $IFIT_MYGET_SOURCE
fi
