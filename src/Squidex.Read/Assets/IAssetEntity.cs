﻿// ==========================================================================
//  IAssetEntity.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;

namespace Squidex.Read.Assets
{
    public interface IAssetEntity : IAppRefEntity, IEntityWithCreatedBy, IEntityWithLastModifiedBy, IEntityWithVersion
    {
        string MimeType { get; }

        string FileName { get; }

        long FileSize { get; }

        long FileVersion { get; }

        bool IsImage { get; }

        int? PixelWidth { get; }

        int? PixelHeight { get; }
    }
}
