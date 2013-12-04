using IntelliCloud.WordStore.Common.Word;
using IntelliCloud.WordStore.Data.Database.Model;
using System.Collections.Generic;
using WordObject = IntelliCloud.WordStore.Common.Word.Word;

namespace IntelliCloud.WordStore.Business.Conversion
{
    /// <summary>
    /// An interface for a conversion object providing all functionality to convert objects.
    /// </summary>
    public interface IConversion
    {
        #region Methods

        WordObject ToWord(WordEntity wordEntity);

        KeywordEntity ToKeywordEntity(string keyword, IEnumerable<WordObject> matchingWords);

        WordType ToWordType(string wordType);

        Language ToLanguage(string language);

        #endregion Methods
    }
}
