#!/bin/bash
# Compiler
for f in $@/*; do g++ $f ${f/.cpp/};done