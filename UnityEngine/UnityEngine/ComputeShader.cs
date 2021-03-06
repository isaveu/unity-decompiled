﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.ComputeShader
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Compute Shader asset.</para>
  /// </summary>
  public sealed class ComputeShader : Object
  {
    /// <summary>
    ///   <para>Find ComputeShader kernel index.</para>
    /// </summary>
    /// <param name="name">Name of kernel function.</param>
    /// <returns>
    ///   <para>Kernel index, or -1 if not found.</para>
    /// </returns>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public int FindKernel(string name);

    /// <summary>
    ///   <para>Set a float parameter.</para>
    /// </summary>
    /// <param name="name">Variable name in shader code.</param>
    /// <param name="val">Value to set.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetFloat(string name, float val);

    /// <summary>
    ///   <para>Set an integer parameter.</para>
    /// </summary>
    /// <param name="name">Variable name in shader code.</param>
    /// <param name="val">Value to set.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetInt(string name, int val);

    /// <summary>
    ///   <para>Set a vector parameter.</para>
    /// </summary>
    /// <param name="name">Variable name in shader code.</param>
    /// <param name="val">Value to set.</param>
    public void SetVector(string name, Vector4 val)
    {
      ComputeShader.INTERNAL_CALL_SetVector(this, name, ref val);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetVector(ComputeShader self, string name, ref Vector4 val);

    /// <summary>
    ///   <para>Set multiple consecutive float parameters at once.</para>
    /// </summary>
    /// <param name="name">Array variable name in the shader code.</param>
    /// <param name="values">Value array to set.</param>
    public void SetFloats(string name, params float[] values)
    {
      this.Internal_SetFloats(name, values);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void Internal_SetFloats(string name, float[] values);

    /// <summary>
    ///   <para>Set multiple consecutive integer parameters at once.</para>
    /// </summary>
    /// <param name="name">Array variable name in the shader code.</param>
    /// <param name="values">Value array to set.</param>
    public void SetInts(string name, params int[] values)
    {
      this.Internal_SetInts(name, values);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private void Internal_SetInts(string name, int[] values);

    /// <summary>
    ///   <para>Set a texture parameter.</para>
    /// </summary>
    /// <param name="kernelIndex">For which kernel the texture is being set. See FindKernel.</param>
    /// <param name="name">Name of the buffer variable in shader code.</param>
    /// <param name="texture">Texture to set.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetTexture(int kernelIndex, string name, Texture texture);

    /// <summary>
    ///   <para>Sets an input or output compute buffer.</para>
    /// </summary>
    /// <param name="kernelIndex">For which kernel the buffer is being set. See FindKernel.</param>
    /// <param name="name">Name of the buffer variable in shader code.</param>
    /// <param name="buffer">Buffer to set.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer);

    /// <summary>
    ///   <para>Execute a compute shader.</para>
    /// </summary>
    /// <param name="kernelIndex">Which kernel to execute. A single compute shader asset can have multiple kernel entry points.</param>
    /// <param name="threadGroupsX">Number of work groups in the X dimension.</param>
    /// <param name="threadGroupsY">Number of work groups in the Y dimension.</param>
    /// <param name="threadGroupsZ">Number of work groups in the Z dimension.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
  }
}
