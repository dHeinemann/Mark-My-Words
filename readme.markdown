Mark My Words is a small tool for previewing Markdown markup as it is
written.  Unlike traditional Markdown editors, Mark My Words is designed
to be used with an external text editor.

To use Mark My Words, open it and browse to a target Markdown file.
Mark My Words will poll the target file for changes every 0.5 seconds,
and re-render it if changes are found.

![Mark My Words][1]

##Features
* Automatically detects changes to and re-renders the open Markdown file
* Jekyll mode - ignores Jekyll data such as title and layout (surrounded
  by '---' marks).

##Download
Installers for Mark My Words can be downloaded [here][2].

##Requirements
The project is written in C#, with the .Net 4.0 framework.

##License
Mark My Words is released under the MIT license.

    Copyright (c) 2012 David Heinemann

    Permission is hereby granted, free of charge, to any person obtaining a
    copy of this software and associated documentation files (the
    "Software"), to deal in the Software without restriction, including
    without limitation the rights to use, copy, modify, merge, publish,
    distribute, sublicense, and/or sell copies of the Software, and to
    permit persons to whom the Software is furnished to do so, subject to
    the following conditions:

    The above copyright notice and this permission notice shall be included
    in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
    OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
    CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
    TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
    SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Mark My Words uses MarkdownDeep by Topten Software, which is published
under the Apache License, version 2.0.  See MarkdownDeep License.txt for
further details.

[1]: https://github.com/dHeinemann/Mark-My-Words/raw/master/screenshot.png
[2]: https://github.com/dHeinemann/Mark-My-Words/downloads
