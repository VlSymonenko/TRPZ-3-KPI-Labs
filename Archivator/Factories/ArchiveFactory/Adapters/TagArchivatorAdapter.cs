using Archivator.ArchiveCreators;
using Archivator.ArchiveTypes;
using Archivator.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archivator.Factories.ArchiveFactory.Adapters
{
    class TagArchivatorAdapter : ArchivatorFactory
    {
        private readonly TagArchivator _tagArchivator;

        public TagArchivatorAdapter(TagArchivator adaptee)
        {
            _tagArchivator = adaptee;
        }

        public override IArchive Archivate()
        {
            var tagArchive = (IArchive)_tagArchivator.CacheArchivate();
            Console.WriteLine("Changing tag archive with adapter");

            return tagArchive;
        }
    }
}
