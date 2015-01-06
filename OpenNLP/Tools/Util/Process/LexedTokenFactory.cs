﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Process
{
    /**
 * Constructs a token (of arbitrary type) from a string and its position
 * in the underlying text.  This is used to create tokens in JFlex lexers
 * such as PTBTokenizer.
 */

    public interface LexedTokenFactory<T>
    {
        /**
   * Constructs a token (of arbitrary type) from a string and its position
   * in the underlying text. (The int arguments are used just to record token
   * character offsets in an underlying text. This method does not take
   * a substring of {@code str}.)
   *
   * @param str The string extracted by the lexer.
   * @param begin The offset in the document of the first character
   *  in this string.
   * @param length The number of characters the string takes up in
   *  the document.
   * @return The token of type T.
   */
        T MakeToken(string str, int begin, int length);
    }
}