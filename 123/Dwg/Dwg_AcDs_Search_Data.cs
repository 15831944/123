//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_AcDs_Search_Data : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_AcDs_Search_Data(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_AcDs_Search_Data obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_AcDs_Search_Data() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_AcDs_Search_Data(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint schema_namidx {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_Data_schema_namidx_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_Search_Data_schema_namidx_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_sortedidx {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_Data_num_sortedidx_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_Search_Data_num_sortedidx_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_long_long sortedidx {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_Data_sortedidx_set(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AcDs_Search_Data_sortedidx_get(swigCPtr);
      SWIGTYPE_p_unsigned_long_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_long_long(cPtr, false);
      return ret;
    } 
  }

  public uint num_ididxs {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_Data_num_ididxs_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_Search_Data_num_ididxs_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_Data_unknown_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_Search_Data_unknown_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_AcDs_Search_IdIdxs ididxs {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_Data_ididxs_set(swigCPtr, Dwg_AcDs_Search_IdIdxs.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AcDs_Search_Data_ididxs_get(swigCPtr);
      Dwg_AcDs_Search_IdIdxs ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_AcDs_Search_IdIdxs(cPtr, false);
      return ret;
    } 
  }

  public Dwg_AcDs_Search_Data() : this(LibreDWGPINVOKE.new_Dwg_AcDs_Search_Data(), true) {
  }

}
