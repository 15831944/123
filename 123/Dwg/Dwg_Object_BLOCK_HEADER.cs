//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_BLOCK_HEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_BLOCK_HEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_BLOCK_HEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_BLOCK_HEADER() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_BLOCK_HEADER(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public ushort flag {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_flag_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_flag_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_name_get(swigCPtr);
      return ret;
    } 
  }

  public ushort used {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_used_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_used_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_xref_ref {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_is_xref_ref_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_is_xref_ref_get(swigCPtr);
      return ret;
    } 
  }

  public ushort is_xref_resolved {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_is_xref_resolved_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_is_xref_resolved_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_xref_dep {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_is_xref_dep_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_is_xref_dep_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref xref {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_xref_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_xref_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public uint __iterator {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER___iterator_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER___iterator_get(swigCPtr);
      return ret;
    } 
  }

  public byte flag2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_flag2_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_flag2_get(swigCPtr);
      return ret;
    } 
  }

  public ushort flag3 {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_flag3_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_flag3_get(swigCPtr);
      return ret;
    } 
  }

  public byte anonymous {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_anonymous_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_anonymous_get(swigCPtr);
      return ret;
    } 
  }

  public byte hasattrs {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_hasattrs_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_hasattrs_get(swigCPtr);
      return ret;
    } 
  }

  public byte blkisxref {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_blkisxref_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_blkisxref_get(swigCPtr);
      return ret;
    } 
  }

  public byte xrefoverlaid {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_xrefoverlaid_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_xrefoverlaid_get(swigCPtr);
      return ret;
    } 
  }

  public byte loaded_bit {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_loaded_bit_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_loaded_bit_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_owned {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_num_owned_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_num_owned_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD base_pt {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_base_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_base_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public string xref_pname {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_xref_pname_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_xref_pname_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_inserts {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_num_inserts_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_num_inserts_get(swigCPtr);
      return ret;
    } 
  }

  public string description {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_description_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_description_get(swigCPtr);
      return ret;
    } 
  }

  public uint preview_size {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_preview_size_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_preview_size_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char preview {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_preview_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_preview_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public ushort insert_units {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_insert_units_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_insert_units_get(swigCPtr);
      return ret;
    } 
  }

  public byte explodable {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_explodable_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_explodable_get(swigCPtr);
      return ret;
    } 
  }

  public byte block_scaling {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_block_scaling_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_block_scaling_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref block_entity {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_block_entity_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_block_entity_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref first_entity {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_first_entity_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_first_entity_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref last_entity {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_last_entity_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_last_entity_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref entities {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_entities_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_entities_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref endblk_entity {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_endblk_entity_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_endblk_entity_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref inserts {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_inserts_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_inserts_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref layout {
    set {
      LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_layout_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_BLOCK_HEADER_layout_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_BLOCK_HEADER() : this(LibreDWGPINVOKE.new_Dwg_Object_BLOCK_HEADER(), true) {
  }

}
