TextJSON
========

TextJSON (version 2) is a format for representation of rich text that can be
saved as plain text with Markdown markup. The main principles are.

-   Content is sequential and semantically has only 1 level—paragraphs.

-   Each paragraph can have several attributes to reflect its style.

-   Hierarchical structure of the text is represented by “levels” of paragraphs
    that correspond to indentation.

-   Runs of characters (spans) inside a paragraph can have different styles.

-   Non-linear structure is represented by assigning IDs to paragraphs and
    referring to them.

A bit more details.

-   Text extracted from all spans of all paragraphs gives whole content of the
    document without any formatting.

-   Editor can use some of paragraph or span styles to customize the
    presentation of the text.

-   Each paragraph is considered a child of the nearest preceding paragraph with
    lower level. Main text is at level 0. Headings have negative levels. Top
    list items are at the main text level.

-   Spans with the same set of styles can be joined without changing semantics.
    When they need to be separated, an empty span with no styles can be
    inserted.

-   Hierarchical structure of spans cannot be represented.

-   Line break inside paragraph is just a character.

Below are examples of different types of content in TextJSON format.

Plain Paragraph
---------------

Emphasis
--------

Heading
-------

Lists
-----

Code
----

Code block should not contain styled spans.

Math
----

Figure
------

With captions.

Table
-----

With captions.

Footnote
--------

Hyperlink
---------

Bare URL or hyperlink with text.

Citation
--------

Cross-reference
---------------

Displays chapter/figure/table number.

Quotation
---------

Author and source of quotation.

Term Definition
---------------

External File
-------------

External code files and document includes.

Comment
-------

Comments are used for collaboration on the content and are not included in the
final document.

Metadata
--------

Authors, title, subtitle, date of the document etc.

Insert
------

Sequences of paragraphs styled differently from the main text.
