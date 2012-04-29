Text JSON
=========

Text JSON is a format for text that is richer then plain text but convenient to
work with. It is inspired by JsonML and Markdown. The following snippet shows an
example of Text JSON data.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
["text",
  ["heading", { "level": 1 },
    ["plain", "Hello "],
    ["emph", "World!"]
  ]
]
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

It represents the following header text.

Hello **World!**
================

Format Description
------------------

Text JSON is a valid JSON and valid JsonML (<http://jsonml.org/>) with the
following restrictions.

  * Root element is named "text".

  * There are always two levels of hierarchy: blocks and spans.

  * Block elements have attributes, even if empty.

  * Span elements have exactly one string content element and do not have
    attributes.

  * Block and span element types must be chosen from the following lists.

  * Data is encoded as UTF-8.

Block Types
~~~~~~~~~~~

  * "heading" — headings of different levels.

  * "para" — plain text paragraph.

  * "listitem" — bulleted list item.

  * "verbatim" — verbatim text block.

Span Types
~~~~~~~~~~

  * "plain" — plain text.

  * "break" — line break (contents is always CR symbol).

  * "emph" — emphasised text.

  * "strong" — strongly emphasised text.

  * "link" — link text.

  * "code" — verbatim text span.

Code Samples
------------

This repository provides several code samples working with Text JSON format in
different programming languages.
