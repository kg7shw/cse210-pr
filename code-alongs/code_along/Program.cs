// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Board _board = new Board();

_board.AddQuote(
    new Quote(
        "—Joseph Smith, 1842",
        "The standard of truth has been erected. No unhallowed hand can stop the work from progressing; persecutions may rage, mobs may combine, armies may assemble, calumny may defame, but the truth of God will go forth boldly, nobly, and independent till it has penetrated every continent, visited every clime, swept every country, and sounded in every ear, till the purposes of God shall be accomplished and the great Jehovah shall say the work is done.",
        new Source("https://www.churchofjesuschrist.org/study/history/saints-v1/epigraph?lang=eng")

    )
);

_board.AddQuote(
    new Quote(
        "Nephi",
        "But behold, all things have been done in the wisdom of him who knoweth all things.",
        new Source("2 Nephi 2:24")

    )
);

_board.AddQuote(
    new Quote(
        "Moroni",
        "And by the power of the Holy Ghost ye may know the truth of all things.",
        new Source("Moroni 10:5")

    )
);

_board.AddQuote(
    new Quote(
        "Moroni",
        "And whatsoever thing is good is just and true; wherefore, nothing that is good denieth the Christ, but acknowledgeth that he is.",
        new Source("Moroni 10:6")

    )
);

_board.AddQuote(
    new Quote(
        "Mormon",
        "And now I, Mormon, make a record of the things which I have both seen and heard, and call it the Book of Mormon.",
        new Source("Mormon 1:1")

    )
);

_board.AddQuote(new Quote("Jacob", "11 O then, my beloved brethren, repent ye, and enter in at the strait gate, and continue in the way which is narrow, until ye shall obtain eternal life.",new Source("Jacob 6:11")));

_board.AddQuote(new Quote("Jacob", "O be wise; what can I say more?",new Source("Jacob 6:12")));

_board.AddQuote(new Quote("Alma", "The soul shall be restored to the body, and the body to the soul; yea, and every limb and joint shall be restored to its body; yea, even a hair of the head shall not be lost; but all things shall be restored to their proper and perfect frame.",new Source("Alma 40:23")));

_board.AddQuote(new Quote("Enos", "And my soul hungered; and I kneeled down before my Maker, and I cried unto him in mighty prayer and supplication for mine own soul;",new Source("Enos 1:4")));

Menu _menu = new Menu(_board);
_menu.Display();


