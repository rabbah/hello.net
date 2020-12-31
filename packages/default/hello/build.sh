#!/bin/bash

SELFDIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
cd ../../../hello
dotnet publish -c Release -o "$SELFDIR"
