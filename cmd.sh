#!/bin/bash
# Compiler
for f in $@/*.cpp; do g++ $f ${f/.cpp/};done