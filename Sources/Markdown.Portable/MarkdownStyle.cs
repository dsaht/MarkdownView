﻿namespace Xam.Forms.Markdown
{

    public class MarkdownStyle
    {
        public FontAttributes Attributes { get; set; } = FontAttributes.None;

        // TODO: can this be named font size stuff?
        public float FontSize { get; set; } = 12;

        public float LineHeight { get; set; } = -1;

        public Color ForegroundColor { get; set; } = Colors.Black;

        public Color BackgroundColor { get; set; } = Colors.Transparent;

        public Color BorderColor { get; set; }

        public float BorderSize { get; set; }

        public string FontFamily { get; set; }

        public TextAlignment HorizontalTextAlignment { get; set; } = TextAlignment.Start;
        public TextAlignment VerticalTextAlignment { get; set; } = TextAlignment.Center;

        public TextDecorations TextDecorations { get; set; } = TextDecorations.None;
    }
}
