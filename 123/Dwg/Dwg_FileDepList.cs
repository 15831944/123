//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_FileDepList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_FileDepList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_FileDepList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_FileDepList() {
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
          LibreDWGPINVOKE.delete_Dwg_FileDepList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint num_features {
    set {
      LibreDWGPINVOKE.Dwg_FileDepList_num_features_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_FileDepList_num_features_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char features {
    set {
      LibreDWGPINVOKE.Dwg_FileDepList_features_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_FileDepList_features_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public uint num_files {
    set {
      LibreDWGPINVOKE.Dwg_FileDepList_num_files_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_FileDepList_num_files_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_FileDepList_Files files {
    set {
      LibreDWGPINVOKE.Dwg_FileDepList_files_set(swigCPtr, Dwg_FileDepList_Files.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_FileDepList_files_get(swigCPtr);
      Dwg_FileDepList_Files ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_FileDepList_Files(cPtr, false);
      return ret;
    } 
  }

  public Dwg_FileDepList() : this(LibreDWGPINVOKE.new_Dwg_FileDepList(), true) {
  }

}
