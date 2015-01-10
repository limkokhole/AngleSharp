﻿namespace AngleSharp.DOM.Html
{
    using AngleSharp.Html;

    /// <summary>
    /// Represents the HTML div element.
    /// </summary>
    sealed class HTMLDivElement : HTMLElement, IHtmlDivElement
    {
        #region ctor

        /// <summary>
        /// Creates a new HTML div element.
        /// </summary>
        public HTMLDivElement(Document owner)
            : base(Tags.Div, NodeFlags.Special)
        {
            Owner = owner;
        }

        #endregion
    }
}
