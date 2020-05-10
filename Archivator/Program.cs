using Archivator.ArchiveCreators;
using Archivator.Factories.ArchiveFactory;
using Archivator.Factories.ArchiveFactory.Adapters;
using Archivator.interfaces;
using System;

namespace Archivator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArchivatorFacade archivatorFacade = new ArchivatorFacade(new ArchivatorAppContext("ArchivatorApp", new ZipArchivator()));
            archivatorFacade.CreateRarArchive();
            archivatorFacade.CreateTagArchive();
            archivatorFacade.CreateZipArchive();
            Console.ReadLine();
        }
    }
}

class ArchivatorAppContext
{
    protected string name;
    public ArchivatorFactory ArchivatorStrategyFactory { get; set; }

    public ArchivatorAppContext(string name, ArchivatorFactory arch)
    {
        this.name = name;
        ArchivatorStrategyFactory = arch;
    }

    public IArchive Archivate()
    {
       return ArchivatorStrategyFactory.Archivate();
    }
}

class ArchivatorFacade
{
    //caching and optimizing subsystems 
    protected ArchivatorAppContext _archivatorSubSystem;

    public ArchivatorFacade(ArchivatorAppContext archivatorSubSystem)
    {
        _archivatorSubSystem = archivatorSubSystem;
    }

    public void CreateTagArchive()
    {
        _archivatorSubSystem.ArchivatorStrategyFactory = new TagArchivatorAdapter(new TagArchivator());
        _archivatorSubSystem.Archivate();
    }
    public void CreateZipArchive()
    {
        _archivatorSubSystem.ArchivatorStrategyFactory = new ZipArchivator();
        _archivatorSubSystem.Archivate();
    }
    public void CreateRarArchive()
    {
        _archivatorSubSystem.ArchivatorStrategyFactory = new RarArchivator();
        _archivatorSubSystem.Archivate();
    }
}



