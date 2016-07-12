﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************
using Microsoft.Windows.Toolkit.Notifications.Adaptive.Elements;
using System;

namespace Microsoft.Windows.Toolkit.Notifications
{
    internal static class BaseImageHelper
    {
        internal static void SetSource(ref string destination, string value)
        {
            if (value == null)
                throw new ArgumentNullException("Source property cannot be null.");

            destination = value;
        }

        internal static Element_AdaptiveImage CreateBaseElement(IBaseImage curr)
        {
            if (curr.Source == null)
                throw new NullReferenceException("Source property is required.");

            return new Element_AdaptiveImage()
            {
                Src = curr.Source,
                Alt = curr.AlternateText,
                AddImageQuery = curr.AddImageQuery
            };
        }
    }
}
