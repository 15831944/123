//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_ODALeader_Line : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_ODALeader_Line(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_ODALeader_Line obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_ODALeader_Line() {
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
          LibreDWGPINVOKE.delete_Dwg_ODALeader_Line(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p__dwg_Leader parent {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_parent_set(swigCPtr, SWIGTYPE_p__dwg_Leader.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ODALeader_Line_parent_get(swigCPtr);
      SWIGTYPE_p__dwg_Leader ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p__dwg_Leader(cPtr, false);
      return ret;
    } 
  }

  public uint num_points {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_num_points_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_num_points_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD points {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_points_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ODALeader_Line_points_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public uint num_breaks {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_num_breaks_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_num_breaks_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_LEADER_Break breaks {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_breaks_set(swigCPtr, Dwg_LEADER_Break.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ODALeader_Line_breaks_get(swigCPtr);
      Dwg_LEADER_Break ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_LEADER_Break(cPtr, false);
      return ret;
    } 
  }

  public uint segment_index {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_segment_index_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_segment_index_get(swigCPtr);
      return ret;
    } 
  }

  public uint index {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_index_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_index_get(swigCPtr);
      return ret;
    } 
  }

  public ushort type {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_type_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color color {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ODALeader_Line_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref ltype {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_ltype_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ODALeader_Line_ltype_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public int linewt {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_linewt_set(swigCPtr, value);
    } 
    get {
      int ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_linewt_get(swigCPtr);
      return ret;
    } 
  }

  public double arrow_size {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_arrow_size_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_arrow_size_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref arrow_handle {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_arrow_handle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ODALeader_Line_arrow_handle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public uint flags {
    set {
      LibreDWGPINVOKE.Dwg_ODALeader_Line_flags_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_ODALeader_Line_flags_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_ODALeader_Line() : this(LibreDWGPINVOKE.new_Dwg_ODALeader_Line(), true) {
  }

}
