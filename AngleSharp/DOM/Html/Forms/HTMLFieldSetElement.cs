﻿namespace AngleSharp.DOM.Html
{
    using AngleSharp.DOM.Collections;
    using AngleSharp.Html;
    using System;

    /// <summary>
    /// Represents the HTML fieldset element.
    /// </summary>
    sealed class HTMLFieldSetElement : HTMLFormControlElement, IHtmlFieldSetElement
    {
        #region ctor

        /// <summary>
        /// Creates a new HTML fieldset element.
        /// </summary>
        public HTMLFieldSetElement(Document owner)
            : base(owner, Tags.Fieldset)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the type of input control (fieldset).
        /// </summary>
        public String Type
        {
            get { return Tags.Fieldset; }
        }

        /// <summary>
        /// Gets the elements belonging to this field set.
        /// </summary>
        public IHtmlFormControlsCollection Elements
        {
            get { return new HtmlFormControlsCollection(Form, this); }
        }

        #endregion

        #region Methods

        protected override Boolean CanBeValidated()
        {
            return true;
        }

        #endregion
    }
}
