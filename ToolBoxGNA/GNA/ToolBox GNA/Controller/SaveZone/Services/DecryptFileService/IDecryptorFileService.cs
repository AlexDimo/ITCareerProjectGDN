﻿using SaveZone.Entities.CheckPasswordBindingModel;
using SaveZone.Entities.DecryptFileBindingModel;

namespace SaveZone.Services.DecryptFileService
{
    public interface IDecryptorFileService
    {
        void AESDecryptFile(string filePath, DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel passwordBindingModel);
    }
}
