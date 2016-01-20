#!/bin/bash
# Compiler
for f in $@/*.cpp; do g++ $f -o ${f/.cpp/};done
# Zipper
for f in $*; do zip $f.zip $f/*;done
