# Social Media Cards With FeatherHTTP

Image manipulation libraries are awesome, but so is HTML and CSS!

Use ASP.NET Core FeatherHTTP and Playwright to generate social media cards.

## Getting Started

Currently, this application is targeting .NET 5 but probably works with .NET Core 3.1.

The program takes two arguments: 

- 0 : Title
- 1 : Image Url 

```console
dotnet run "hello, world" "https://images.unsplash.com/photo-1611421964991-011ddb6c2cea?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1265&q=80"
```

When run, the application will make a call to a Razor Page (Index.cshtml). Feel free to change it for your needs.

The final output will look something like this.

![hello, world](./hello-world.png)

## License

Copyright © 2021 Khalid Abuhakmeh

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.