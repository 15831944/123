//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_GEODATA_meshface : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_GEODATA_meshface(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_GEODATA_meshface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_GEODATA_meshface() {
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
          LibreDWGPINVOKE.delete_Dwg_GEODATA_meshface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint face1 {
    set {
      LibreDWGPINVOKE.Dwg_GEODATA_meshface_face1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_GEODATA_meshface_face1_get(swigCPtr);
      return ret;
    } 
  }

  public uint face2 {
    set {
      LibreDWGPINVOKE.Dwg_GEODATA_meshface_face2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_GEODATA_meshface_face2_get(swigCPtr);
      return ret;
    } 
  }

  public uint face3 {
    set {
      LibreDWGPINVOKE.Dwg_GEODATA_meshface_face3_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_GEODATA_meshface_face3_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_GEODATA_meshface() : this(LibreDWGPINVOKE.new_Dwg_GEODATA_meshface(), true) {
  }

}
