//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_MESH_edge : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_MESH_edge(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_MESH_edge obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_MESH_edge() {
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
          LibreDWGPINVOKE.delete_Dwg_MESH_edge(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Entity_MESH parent {
    set {
      LibreDWGPINVOKE.Dwg_MESH_edge_parent_set(swigCPtr, Dwg_Entity_MESH.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MESH_edge_parent_get(swigCPtr);
      Dwg_Entity_MESH ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Entity_MESH(cPtr, false);
      return ret;
    } 
  }

  public uint from {
    set {
      LibreDWGPINVOKE.Dwg_MESH_edge_from_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_MESH_edge_from_get(swigCPtr);
      return ret;
    } 
  }

  public uint to {
    set {
      LibreDWGPINVOKE.Dwg_MESH_edge_to_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_MESH_edge_to_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_MESH_edge() : this(LibreDWGPINVOKE.new_Dwg_MESH_edge(), true) {
  }

}
