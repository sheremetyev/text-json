TextJSON
========

TextJSON is a format for text that is richer then plain text but convenient to
work with. It is inspired by JsonML and Markdown. The following snippet shows an
example of TextJSON data.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
["text",
  ["para", { "level": 0 },
    ["plain", "Hello "],
    ["emph", "World!"]
  ]
]
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

It represents the following text.

Hello **World!**

Format Description
------------------

TextJSON is valid JSON and valid [JsonML][1] with additional requirements.

[1]: <http://en.wikipedia.org/wiki/JsonML>

-   Root element is named "text".

-   There are always two levels of hierarchy: blocks and spans.

-   Block elements have attributes, even if empty.

-   Span elements have exactly one string content element and do not have
    attributes.

-   Block and span element types must be chosen from the following lists.

-   Data is encoded as UTF-8.

### Block Types

-   "heading" — headings of different levels.

-   "para" — plain text paragraph.

-   "item" — bulleted or numbered list item or table cell.

-   "verbatim" — verbatim text block.

-   "note" — a footnote.

-   "link" — external link definition, with alternative text.

-   "image" — link to a PNG or JPEG file.

-   "description" — a title for image, table, verbatim block or formula.

-   "displaymath" — a formula.

-   "divider" — a horizontal line.

### Span Types

-   "plain" — plain text.

-   "break" — line break (contents is always CR symbol).

-   "emph" — emphasised text.

-   "strong" — strongly emphasised text.

-   "url" — an URL.

-   "linktext" — text to be shown instead of URL or reference.

-   "code" — verbatim text span.

-   "label" — marker for a block.

-   "ref" — reference to a label.

-   "math" - an inlinde formula.

### Referencing

Most of the text in documents is linear — sequential paragraphs. This maps
perfectly into the two-level structure of blocks and spans in TextJSON.

But there are a few common cases where more complex structure is required —
links, footnotes and cross-references. TextJSON deals with these case by
introducing a level of indirection as Markdown and LaTeX do.

Labels can be assigned to a paragraph and then referred to from another place.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
["text",
  ["para", {},
    ["plain", "It is mentioned"],
    ["ref", "mynote"],
    ["plain", " in a footnote."],
  ],
  ["note", {},
    ["label", "mynote"],
    ["plain", "This is a footnote."]
  ]
]
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Blocks with notes can be placed anywhere in the text. When converted to other
formats (HTML, PDF, etc.) they will be pulled out from that location and placed
accordingly to the destination format rules.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
["text",
  ["para", {},
    ["plain", "See picture "],
    ["ref", "myimage"],
    ["plain", " for example."],
  ],
  ["image", {},
    ["label", "myimage"],
    ["url", "picture.jpg"]
    ["plain", "Alternative text for image."]
  ]
  ["description", {},
    ["plain", "Figure title."]
  ]
]
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

The same mechanism can be used for links with alternative text.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
["text",
  ["para", {},
    ["plain", "See "],
    ["linktext", "my web site"]
    ["ref", "mysite"],
    ["plain", " for details."],
  ],
  ["link", {},
    ["label", "mysite"],
    ["url", "http://mywebsite.com"],
    ["plain", "Alternative text for the link."]
  ]
]
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Code Samples
------------

This repository provides several code samples working with TextJSON format in
different programming languages.
