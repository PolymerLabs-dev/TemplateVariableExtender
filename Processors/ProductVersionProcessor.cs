﻿using UnityEngine;

namespace TemplateVariableExtender.Processors {
  public class ProductVersionProcessor : KeywordProcessor {
    public ProductVersionProcessor() : base("PRODUCT_VERSION") { }

    protected override string ProcessExecutor(AssetInfo assetInfo) {
      return $"{Application.unityVersion}";
    }
  }
}