using System;
using System.Collections.Generic;
using PetShelterLib;

namespace PetShelterList
{
    public class AdoptionStorageList : IAdoptionStorage {
        List<Adoption> _adoptionList;

        public AdoptionStorageList() {
            _adoptionList = new List<Adoption>();
        }

        public List<Adoption> GetAll() {
            return _adoptionList;
        }

        public void Save(Adoption adoptionRecord) {
            _adoptionList.Add(adoptionRecord);
        }

    }
}
